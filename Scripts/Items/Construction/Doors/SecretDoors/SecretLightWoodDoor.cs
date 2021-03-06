namespace Server.Items
{
    public class SecretLightWoodDoor : BaseDoor
    {
        [Constructable]
        public SecretLightWoodDoor( DoorFacing facing ) : base( 0x344 + (2 * (int)facing), 0x345 + (2 * (int)facing), 0xED, 0xF4, BaseDoor.GetOffset( facing ) )
        {
        }

        public SecretLightWoodDoor( Serial serial ) : base( serial )
        {
        }

        public override void Serialize( GenericWriter writer ) // Default Serialize method
        {
            base.Serialize( writer );

            writer.Write( (int) 0 ); // version
        }

        public override void Deserialize( GenericReader reader ) // Default Deserialize method
        {
            base.Deserialize( reader );

            int version = reader.ReadInt();
        }
    }
}