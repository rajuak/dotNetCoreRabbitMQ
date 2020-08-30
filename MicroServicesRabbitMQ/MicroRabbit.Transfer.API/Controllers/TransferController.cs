﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {

        private readonly ITransferService _transferService;


        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        //Get api/transfer

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {

            return Ok(_transferService.GetTransferLogs());
            
        }
    }
}
