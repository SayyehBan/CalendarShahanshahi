using System.Globalization;

namespace CalendarShahanshahi
{
    public partial class Form1 : Form
    {
        private readonly PersianDateConverter converter;
        public Form1()
        {
            InitializeComponent();
            converter = new PersianDateConverter();
        }
        private void btnMiladiToShamsiAndShahanshahi_Click(object sender, EventArgs e)
        {
            try
            {
                // تنظیم فرهنگ به میلادی برای پارس کردن تاریخ ورودی
                CultureInfo miladiCulture = new CultureInfo("en-US");
                if (DateTime.TryParse(TxtMiladiToShamsiAndShahanshahi.Text, miladiCulture, DateTimeStyles.None, out DateTime miladiDate))
                {
                    string result1 = converter.MiladiToShamsiAndShahanshahi(miladiDate, 1); // فرمت yyyy/MM/dd
                    string result2 = converter.MiladiToShamsiAndShahanshahi(miladiDate, 2); // فرمت yyyy/MM/dd
                    string result3 = converter.MiladiToShamsiAndShahanshahi(miladiDate, 3); // فرمت yyyy/MM/dd
                    string result4 = converter.MiladiToShamsiAndShahanshahi(miladiDate, 4); // فرمت yyyy/MM/dd
                    string result5 = converter.MiladiToShamsiAndShahanshahi(miladiDate, 5); // فرمت yyyy/MM/dd
                    lblMiladiToShamsiAndShahanshahi.Text = result1 + "\n"
                        + result2 + "\n"
                        + result3 + "\n"
                        + result4 + "\n" +
                        result5;

                }
                else
                {
                    lblMiladiToShamsiAndShahanshahi.Text = "لطفاً تاریخ را با فرمت صحیح وارد کنید (مثلاً 1992-03-06).";
                }
            }
            catch (Exception ex)
            {
                lblMiladiToShamsiAndShahanshahi.Text = "خطایی رخ داد: " + ex.Message;
            }
        }
        private void btnShahanshahiToMiladi_Click(object sender, EventArgs e)
        {
            try
            {
                // گرفتن تاریخ کامل از تکست‌باکس (مثلاً 2550/12/16)
                string input = txtShahanshahiToMiladi.Text.Trim();
                string[] parts = input.Split('/');

                if (parts.Length == 3 &&
                    int.TryParse(parts[0], out int shahanshahiYear) &&
                    int.TryParse(parts[1], out int shamsiMonth) &&
                    int.TryParse(parts[2], out int shamsiDay))
                {
                    // اعتبارسنجی ساده
                    if (shamsiMonth < 1 || shamsiMonth > 12 || shamsiDay < 1 || shamsiDay > 31)
                    {
                        lblShahanshahiToMiladi.Text = "ماه باید بین 1-12 و روز بین 1-31 باشد.";
                        return;
                    }

                    // تبدیل شاهنشاهی به میلادی
                    DateTime miladiDate = converter.ShahanshahiToMiladi(input);

                    // نمایش تاریخ میلادی با فرمت استاندارد
                    CultureInfo miladiCulture = new CultureInfo("en-US"); // خروجی به‌عنوان میلادی
                    lblShahanshahiToMiladi.Text = miladiDate.ToString("yyyy-MM-dd", miladiCulture);
                    Clipboard.SetText(lblShahanshahiToMiladi.Text);
                }
                else
                {
                    lblShahanshahiToMiladi.Text = "لطفاً تاریخ را با فرمت yyyy/MM/dd وارد کنید (مثلاً 2550/12/16).";
                }
            }
            catch (Exception ex)
            {
                lblShahanshahiToMiladi.Text = "خطایی رخ داد: " + ex.Message;
            }
        }
    }
}