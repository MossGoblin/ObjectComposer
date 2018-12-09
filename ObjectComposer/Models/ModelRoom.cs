using ObjectComposer.Models.Attributes;
using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models
{
    class ModelRoom : IComposite
    {
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        [Scalable("int")]
        public int Area
        {
            get { return width * height; }
        }

        private decimal ruinState;

        [Scalable("decimal")]
        public decimal RuinState
        {
            get { return ruinState; }
            set { ruinState = value; }
        }
        private string indexNumber;

        [Listable("string")]
        public string IndexNumber
        {
            get { return indexNumber; }
            set { indexNumber = value; }
        }

        private RoomType roomType;

        [Listable("RoomType")]
        public RoomType RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        private RoomProfile roomProfile;

        [Listable("RoomProfile")]
        public RoomProfile RoomProfile
        {
            get { return roomProfile; }
            set { roomProfile = value; }
        }
        private bool hasSecretEntrance;
            
        [Checkable("bool")]
        public bool HasSecretEntrance
        {
            get { return hasSecretEntrance; }
            set { hasSecretEntrance = value; }
        }

        public ModelRoom(int width, int height, decimal ruinState, string indexNumber, RoomType roomType, RoomProfile roomProfile, bool hasSecretEntrance)
        {
            this.Width = width;
            this.Height = height;
            this.RuinState = ruinState;
            this.IndexNumber = indexNumber;
            this.RoomType = roomType;
            this.RoomProfile = roomProfile;
            this.HasSecretEntrance = hasSecretEntrance;
        }
    }
}
