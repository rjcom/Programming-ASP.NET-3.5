using System;

public static class StringExt
{
   public static string PrefixWith(this string someString, string prefixString)
   {
      return prefixString + someString;
   }
}
