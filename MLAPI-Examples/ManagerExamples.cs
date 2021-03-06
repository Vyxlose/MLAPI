using MLAPI;
using MLAPI.Components;
using MLAPI.Cryptography;
using MLAPI.Data;

namespace MLAPI_Examples
{
    // Features example calls for things often needed for things like Game managers
    public class ManagerExamples : NetworkedBehaviour
    {
        public NetworkedObject GetPlayerGameObject(uint clientId)
        {
            return SpawnManager.GetPlayerObject(clientId);
        }
        
        // Only runs on host and client
        public NetworkedObject GetLocalPlayerObject()
        {
            return SpawnManager.GetLocalPlayerObject();
        }
        
        // Only runs on server
        public byte[] GetAESKeyForClient(uint clientId)
        {
            return CryptographyHelper.GetClientKey(clientId);
        }

        // Only runs on client
        public byte[] GetAESKeyForServer()
        {
            return CryptographyHelper.GetServerKey();
        }

        // Contains player object, owned objects, cryptography keys and more
        public NetworkedClient GetClient(uint clientId)
        {
            return NetworkingManager.Singleton.ConnectedClients[clientId];
        }
    }
}