using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var phoneNumberSplited = phoneNumber.Split('-');
        return (phoneNumberSplited[0].StartsWith("212"), phoneNumberSplited[1].Contains("555"), phoneNumberSplited[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
