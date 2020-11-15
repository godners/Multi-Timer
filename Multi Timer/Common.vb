Module Common
    Public Function NowString(dt As DateTime) As String
        Return dt.ToString("yyyy-MM-dd HH:mm:ss ", Globalization.CultureInfo.CreateSpecificCulture("en-US")) & dt.DayOfWeek
    End Function

End Module
