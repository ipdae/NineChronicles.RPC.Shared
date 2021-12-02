using System.Collections.Generic;
using System.Threading;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes, CancellationToken shutdownToken);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes, CancellationToken shutdownToken);

        UnaryResult<byte[]> GetState(byte[] addressBytes, CancellationToken shutdownToken);

        UnaryResult<byte[]> GetBalance(byte[] addressBytes, byte[] currencyBytes, CancellationToken shutdownToken);
        
        UnaryResult<byte[]> GetTip(CancellationToken shutdownToken);

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes, CancellationToken shutdownToken);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes, CancellationToken shutdownToken);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);
    }
}
