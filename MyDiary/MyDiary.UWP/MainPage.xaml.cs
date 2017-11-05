namespace MyDiary.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new MyDiary.App());
        }
    }
}