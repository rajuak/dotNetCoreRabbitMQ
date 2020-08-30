using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {

        private readonly ITransferRepository _trasnferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _trasnferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _trasnferRepository.GetTransferLogs();
        }

    }
}
