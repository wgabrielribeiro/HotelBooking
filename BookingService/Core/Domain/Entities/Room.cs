namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public bool inMaintenance { get; set; }
        public bool IsAvailable 
        {
            get
            {
                if(this.inMaintenance || this.HasGuest)
                {
                    return false;
                }
                return true;
            }            
        }
        public bool HasGuest 
        { 
            //verificar se existem bookins abertos para esta room
            get 
            {
                return true;
            } 
        }
    }
}
