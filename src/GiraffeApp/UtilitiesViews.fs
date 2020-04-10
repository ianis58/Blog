namespace GiraffeApp.Views

module Utilities =

    open System
    open System.Globalization

    let cultureInfo = CultureInfo("fr-FR")

    let dateFormatDayMonthYear (date : DateTime) = date.ToString("dd MMMM yyyy", cultureInfo)
