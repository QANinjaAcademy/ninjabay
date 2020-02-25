﻿using MediatR;
using SenacSp.ProjetoIntegrador.Domain.Results;
using SenacSp.ProjetoIntegrador.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacSp.ProjetoIntegrador.Domain.Commands.Products
{
    public class InsertProductImageCommand : IRequest<DefaultResult>
    {
        public Guid ProductId { get; set; }

        public IEnumerable<FileInput> Files { get; set; } = new List<FileInput>();
    }
}