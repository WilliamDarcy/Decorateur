namespace DecorateurPattern
{
    public abstract class DecorateurPate : AbstractPate
    {
        protected Pate Pate;

        protected DecorateurPate(Pate laPate)
        {
            Pate = laPate;
        }

        public override string AfficherIngredient()
        {
            return Pate?.AfficherIngredient();
        }

        public abstract string AjouterIngredient();

    }
}