namespace SH.Framework.Library.OpenApi.Implementation;

public static class OpenApiExtensions
{
    public static string CreateFriendlyId(Type type)
    {
        if (type.IsArray)
        {
            return $"{CreateFriendlyId(type.GetElementType()!)}Array";
        }

        if (type.IsGenericType)
        {
            var nameBuilder = new System.Text.StringBuilder();

            var cleanName = type.Name.Split('`')[0];
            nameBuilder.Append(cleanName);
            nameBuilder.Append("Of");

            var args = type.GetGenericArguments();
            for (int i = 0; i < args.Length; i++)
            {
                nameBuilder.Append(CreateFriendlyId(args[i]));
            }

            return nameBuilder.ToString();
        }

        if (type.IsNested && type.DeclaringType != null)
        {
            return $"{CreateFriendlyId(type.DeclaringType)}{type.Name}";
        }

        var id = type.Name;

        return id
            .Replace("[]", "Array")
            .Replace("[", "")
            .Replace("]", "")
            .Replace(",", "")
            .Replace("+", "");
    }
}