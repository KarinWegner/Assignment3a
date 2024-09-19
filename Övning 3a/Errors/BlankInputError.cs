namespace Övning_3a.Errors
{
    internal class BlankInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input that had no characters except spacebar. This fired an error!";
        }
    }
}