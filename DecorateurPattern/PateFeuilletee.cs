namespace DecorateurPattern
{
    public class PateFeuilletee : DecorateurPate
    {
        public PateFeuilletee(Pate laPate) : base(laPate)
        {
            
        }

        

        public override string AjouterIngredient()
        {
            return "Ajout de feuilletage";
        }
    }
}