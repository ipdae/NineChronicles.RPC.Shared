using System.Collections.Generic;
using System.Threading.Tasks;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes);

        UnaryResult<byte[]> GetState(byte[] addressBytes);

        UnaryResult<byte[]> GetBalance(byte[] addressBytes, byte[] currencyBytes);
        
        UnaryResult<byte[]> GetTip();

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);

        Task<UnaryResult<Dictionary<byte[], byte[]>>> GetAvatarStates(IEnumerable<byte[]> addressBytesList);

        Task<UnaryResult<Dictionary<byte[], byte[]>>> GetStateBulk(IEnumerable<byte[]> addressBytesList);
    }
}
