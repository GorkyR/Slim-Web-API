namespace Core;

public static class Extensions {
   public static string PascalCaseToUpperSnakeCase(this string text) =>
      string.Join(string.Empty, (text ?? string.Empty).Select(c => char.IsUpper(c) ? $"_{c}" : $"{c}")).TrimStart('_').ToUpper();
}