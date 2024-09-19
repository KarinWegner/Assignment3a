namespace Övning_3a.Errors
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to leave a required field empty. This fired an error!";
        }
    }
}