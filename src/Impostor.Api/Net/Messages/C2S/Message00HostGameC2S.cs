﻿using Impostor.Api.Innersloth;

namespace Impostor.Api.Net.Messages.C2S
{
    public static class Message00HostGameC2S
    {
        public static void Serialize(IMessageWriter writer, GameOptionsData gameOptionsData)
        {
            writer.StartMessage(MessageFlags.HostGame);
            gameOptionsData.Serialize(writer);
            writer.EndMessage();
        }

        public static GameOptionsData Deserialize(IMessageReader reader, out ChatType chatType)
        {
            var gameOptionsData = GameOptionsData.DeserializeCreate(reader);
            chatType = (ChatType)reader.ReadByte();

            return gameOptionsData;
        }
    }
}
