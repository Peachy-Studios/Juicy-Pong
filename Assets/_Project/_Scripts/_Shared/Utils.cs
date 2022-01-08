public static class Utils
{
    public static object GetPropertyValue(object obj, string propertyName)
    {
        return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
    }

    public static void SetPropertyValue(object obj, string propertyName, object value)
    {
        obj.GetType().GetProperty(propertyName).SetValue(obj, value);
    }

}
