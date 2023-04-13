﻿using CommentManagement.Application.Contracts.CommentAggregate;
using CommentManagement.Application.Implementations;
using CommentManagement.Domain.CommentAggregate;
using CommentManagement.Infrastructure.EFCore;
using CommentManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentManagement.Infrastructure.Configuration
{
    public class CommentManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICommentApplication, CommentApplication>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            services.AddDbContext<CommentDbContext>(ob=>ob.UseSqlServer(connectionString));
        }
    }
}
