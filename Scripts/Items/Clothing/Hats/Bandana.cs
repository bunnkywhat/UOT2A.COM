namespace Server.Items
{
    public class Bandana : BaseHat
    {
        public override int BasePhysicalResistance{ get{ return 0; } }
        public override int BaseFireResistance{ get{ return 3; } }
        public override int BaseColdResistance{ get{ return 5; } }
        public override int BasePoisonResistance{ get{ return 8; } }
        public override int BaseEnergyResistance{ get{ return 8; } }

        public override int InitMinHits{ get{ return 20; } }
        public override int InitMaxHits{ get{ return 30; } }

        [Constructable]
        public Bandana() : this( 0 )
        {
        }

        [Constructable]
        public Bandana( int hue ) : base( 0x1540, hue )
        {
            Weight = 1.0;
        }

        public Bandana( Serial serial ) : base( serial )
        {
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );

            writer.Write( (int) 0 ); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );

            int version = reader.ReadInt();
        }
    }
}