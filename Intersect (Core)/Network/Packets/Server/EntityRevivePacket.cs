﻿using System;

using Intersect.Enums;

namespace Intersect.Network.Packets.Server
{

    public class EntityRevivePacket : CerasPacket
    {

        public EntityRevivePacket(Guid id, EntityTypes type, Guid mapId)
        {
            Id = id;
            Type = type;
            MapId = mapId;
        }

        public Guid Id { get; set; }

        public EntityTypes Type { get; set; }

        public Guid MapId { get; set; }

    }

}
