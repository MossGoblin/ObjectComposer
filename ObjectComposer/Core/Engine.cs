using ObjectComposer.Core.Contracts;
using ObjectComposer.Models;
using ObjectComposer.Models.Attributes;
using ObjectComposer.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposer.Core
{
    public class Engine : IEngine
    {
        
        public void Run()
        {
            Gatherer gatherer = new Gatherer();
            gatherer.AddObject(new ModelRoom(1, 2, 10, "00Room", RoomType.Storage, RoomProfile.Medical, true));
            gatherer.AddObject(new ModelRoom(2, 2, 12, "01Room", RoomType.Storage, RoomProfile.Medical, false));
            gatherer.AddObject(new ModelRoom(3, 3, 15, "02Room", RoomType.Storage, RoomProfile.Military, true));
            gatherer.AddObject(new ModelRoom(4, 3, 32, "03Room", RoomType.Storage, RoomProfile.General, false));
            gatherer.AddObject(new ModelRoom(5, 4, 60, "04Room", RoomType.Storage, RoomProfile.Science, false));
            gatherer.AddObject(new ModelRoom(1, 2, 10, "05Room", RoomType.Work, RoomProfile.Military, true));
            gatherer.AddObject(new ModelRoom(2, 2, 12, "06Room", RoomType.Work, RoomProfile.Military, false));
            gatherer.AddObject(new ModelRoom(3, 3, 15, "07Room", RoomType.Work, RoomProfile.Medical, true));
            gatherer.AddObject(new ModelRoom(4, 3, 32, "08Room", RoomType.Work, RoomProfile.General, false));
            gatherer.AddObject(new ModelRoom(5, 4, 60, "09Room", RoomType.Work, RoomProfile.Science, true));
            gatherer.AddObject(new ModelRoom(1, 2, 10, "10Room", RoomType.Quarters, RoomProfile.General, false));
            gatherer.AddObject(new ModelRoom(2, 2, 12, "11Room", RoomType.Quarters, RoomProfile.General, true));
            gatherer.AddObject(new ModelRoom(3, 3, 15, "12Room", RoomType.Quarters, RoomProfile.Medical, false));
            gatherer.AddObject(new ModelRoom(4, 3, 32, "13Room", RoomType.Quarters, RoomProfile.Military, false));
            gatherer.AddObject(new ModelRoom(5, 4, 60, "14Room", RoomType.Quarters, RoomProfile.Science, false));

            List<IElement> gatheredObjects = gatherer.GetObjectList();

            Composer composer = new Composer(gatheredObjects);

            composer.CreateFilter(FilterType.CheckableSifter, "HasSecretEntrance", "true");
            composer.TestCheckablesExlusionSifter();
            Console.ReadLine();
        }
    }
}
