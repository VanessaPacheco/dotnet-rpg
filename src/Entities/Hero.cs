namespace dotnet_rpg.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return "\n" + this.Name + " " + this.Level + " " + this.HeroType + "\n\n";
        }

        public virtual string Attack(){
            return this.Name + " atacou com a sua espada\n";
        }
    }
}