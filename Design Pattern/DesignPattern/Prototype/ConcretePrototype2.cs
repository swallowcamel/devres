namespace DesignPattern
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }
        public override Prototype Clone()
        {
            //浅表复制
            return (Prototype)this.MemberwiseClone();
        }
    }
}