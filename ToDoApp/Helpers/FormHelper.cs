
namespace ToDoApp.Helpers
{
    public static class FormHelper
    {
        public static void SetAnchors(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is GroupBox || control is Panel)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (control is Button)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else if (control is Label)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }

                if (control.HasChildren)
                {
                    SetAnchors(control);
                }
            }
        }
    }
}
