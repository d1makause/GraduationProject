namespace WinFormsApplication
{
    public class EditContext
    {
        private readonly List<Verification> _verifications;

        public EditContext()
        {
            _verifications = new();
        }

        public void Create(Control control, Label label, Func<bool> predicate)
        {
            _verifications.Add(new()
            {
                Control = control,
                Label = label,
                Expr = predicate,
            });

            control.TextChanged += (s, e) => RemoveMarks(control, label);
        }

        public bool VerifyAll()
        {
            var result = true;

            foreach (var validation in _verifications)
            {
                if (VerifySingle(validation.Expr, validation.Control, validation.Label) == false)
                {
                    result = false;
                }
            }

            return result;
        }

        private void MarkInvalid(Control control, Label label)
        {
            control.ForeColor = Color.Red;

            label.ForeColor = Color.Red;
        }

        private void MarkValid(Control control, Label label)
        {
            control.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private void RemoveMarks(Control control, Label label)
        {
            control.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }

        private bool VerifySingle(Func<bool> condition, Control control, Label label)
        {
            var result = condition();

            if (result)
            {
                MarkValid(control, label);
            }
            else
            {
                MarkInvalid(control, label);
            }

            return result;
        }

        public class Verification
        {
            public Control Control { get; set; }

            public Label Label { get; set; }

            public Func<bool> Expr { get; set; }
        }
    }
}
