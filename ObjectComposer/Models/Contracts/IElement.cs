using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Models.Contracts
{
    public interface IElement
    {
        int Width { get; set; }
        int Height { get; set; }
        decimal RuinState { get; set; }
        string IndexNumber { get; set; }
        RoomType RoomType { get; set; }
        RoomProfile RoomProfile { get; set; }

        bool HasSecretEntrance { get; set; }
    }
}
