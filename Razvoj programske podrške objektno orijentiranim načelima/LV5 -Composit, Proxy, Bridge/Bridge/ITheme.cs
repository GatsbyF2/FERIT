public interface ITheme
{
    void SetBackgroundColor();
    void SetFontColor();
    string GetHeader(int width);
    string GetFooter(int width);
}
