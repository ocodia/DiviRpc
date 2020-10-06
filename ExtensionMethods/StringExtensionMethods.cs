namespace DiviSharp.ExtensionMethods
{
    public static class StringExtensionMethods
    {
        public static string Shorten(this string statement, int amt)
        {
            if (!string.IsNullOrEmpty(statement))
            {
                if (statement.Length > amt)
                {
                    return statement.Substring(0, amt) + "...";
                }
                else
                {
                    return statement;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
