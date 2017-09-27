namespace GUI.Classes
{
    public static class Helpers
    {
        public static string FormatStats(string label, int? number)
        {
            var numberAsString = (number.HasValue ? number.ToString() : "?").PadLeft(3);

            return $"{label}: {numberAsString}".PadLeft(25);
        }
    }
}
