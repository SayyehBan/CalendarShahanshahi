namespace CalendarShahanshahi;

using System;
using System.Globalization;

public class PersianDateConverter
{
    // تبدیل تاریخ میلادی به شاهنشاهی 
    public string MiladiToShamsiAndShahanshahi(DateTime miladiDate, int formatType = 1)
    {
        // استفاده از PersianCalendar برای تبدیل میلادی به شمسی
        PersianCalendar persianCalendar = new PersianCalendar();

        // مطمئن می‌شیم که تاریخ ورودی به‌عنوان میلادی تفسیر بشه
        CultureInfo miladiCulture = new CultureInfo("en-US"); // فرهنگ میلادی
        int jYear = persianCalendar.GetYear(miladiDate);
        int jMonth = persianCalendar.GetMonth(miladiDate);
        int jDay = persianCalendar.GetDayOfMonth(miladiDate);

        // دیباگ برای بررسی مقادیر
        Console.WriteLine($"jYear: {jYear}, jMonth: {jMonth}, jDay: {jDay}");

        // تبدیل سال شمسی به شاهنشاهی
        int shahanshahiYear = jYear + 1180; // اختلاف ثابت (مثلاً 1370 به 2550)

        // تنظیم نام ماه به فارسی
        string persianMonthName = jMonth switch
        {
            1 => "فروردین",
            2 => "اردیبهشت",
            3 => "خرداد",
            4 => "تیر",
            5 => "مرداد",
            6 => "شهریور",
            7 => "مهر",
            8 => "آبان",
            9 => "آذر",
            10 => "دی",
            11 => "بهمن",
            12 => "اسفند",
            _ => ""
        };

        // تنظیم نام روز هفته به فارسی
        string persianDayName = miladiDate.DayOfWeek switch
        {
            DayOfWeek.Sunday => "یک‌شنبه",
            DayOfWeek.Monday => "دوشنبه",
            DayOfWeek.Tuesday => "سه‌شنبه",
            DayOfWeek.Wednesday => "چهارشنبه",
            DayOfWeek.Thursday => "پنج‌شنبه",
            DayOfWeek.Friday => "جمعه",
            DayOfWeek.Saturday => "شنبه",
            _ => ""
        };

        // انتخاب فرمت خروجی
        string outputFormat = formatType switch
        {
            1 => $"{shahanshahiYear}/{jMonth:D2}/{jDay:D2}",
            2 => $"{shahanshahiYear}/{persianMonthName}/{jDay:D2}",
            3 => $"{shahanshahiYear}/{jMonth:D2}/{persianDayName}",
            4 => $"{shahanshahiYear}/{persianMonthName}/{persianDayName}",
            5 => $"{shahanshahiYear}/{persianDayName}/{persianMonthName}",
            _ => $"{shahanshahiYear}/{jMonth:D2}/{jDay:D2}"
        };

        return outputFormat;
    }


    //  تبدیل شاهنشاهی به میلادی
    public DateTime ShahanshahiToMiladi(int shahanshahiYear, int shamsiMonth, int shamsiDay)
    {
        // تبدیل سال شاهنشاهی به شمسی
        int shamsiYear = shahanshahiYear - 1180; // اختلاف ثابت

        // تبدیل شمسی به میلادی
        int baseShamsiYear = 1300;
        DateTime baseMiladiDate = new DateTime(1921, 3, 21); // معادل 1 فروردین 1300
        int daysSinceBase = 0;

        // محاسبه تعداد روزهای کامل سال‌های گذشته
        int yearsDiff = shamsiYear - baseShamsiYear;
        int daysInYear;
        int tempYear = baseShamsiYear;

        while (tempYear < shamsiYear)
        {
            daysInYear = (tempYear % 33 == 1 || tempYear % 33 == 5 || tempYear % 33 == 9 ||
                          tempYear % 33 == 13 || tempYear % 33 == 17 || tempYear % 33 == 22 ||
                          tempYear % 33 == 26 || tempYear % 33 == 30) ? 366 : 365;
            daysSinceBase += daysInYear;
            tempYear++;
        }
        while (tempYear > shamsiYear)
        {
            tempYear--;
            daysInYear = (tempYear % 33 == 1 || tempYear % 33 == 5 || tempYear % 33 == 9 ||
                          tempYear % 33 == 13 || tempYear % 33 == 17 || tempYear % 33 == 22 ||
                          tempYear % 33 == 26 || tempYear % 33 == 30) ? 366 : 365;
            daysSinceBase -= daysInYear;
        }

        // اضافه کردن روزهای ماه‌ها
        int tempMonth = 1;
        int daysInMonth;
        while (tempMonth < shamsiMonth)
        {
            daysInMonth = tempMonth <= 6 ? 31 :
                          tempMonth <= 11 ? 30 :
                          (shamsiYear % 33 == 1 || shamsiYear % 33 == 5 || shamsiYear % 33 == 9 ||
                           shamsiYear % 33 == 13 || shamsiYear % 33 == 17 || shamsiYear % 33 == 22 ||
                           shamsiYear % 33 == 26 || shamsiYear % 33 == 30) ? 30 : 29;
            daysSinceBase += daysInMonth;
            tempMonth++;
        }

        // اضافه کردن روزهای باقی‌مانده
        daysSinceBase += (shamsiDay - 1);

        // محاسبه تاریخ میلادی
        DateTime miladiDate = baseMiladiDate.AddDays(daysSinceBase);

        return miladiDate;
    }

}