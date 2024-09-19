namespace Övning_3a.Errors
{
    internal class ExcessInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input an input outside of the input storage limit. This fired an error!";
        }
    }
}