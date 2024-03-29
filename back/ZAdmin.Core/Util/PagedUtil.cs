﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZAdmin.Core.Util
{
    public static class PagedUtil
    {
        /// <summary>
        /// 分页拓展
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <param name="pageIndex">页码，必须大于0</param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<PageResult<TEntity>> ToADPagedListAsync<TEntity>(this IQueryable<TEntity> entities, int pageIndex = 1, int pageSize = 20, CancellationToken cancellationToken = default)
        {
            if (pageIndex <= 0) throw new InvalidOperationException($"{nameof(pageIndex)} 必须是大于0的正整数。");

            var totalCount = await entities.CountAsync(cancellationToken);
            var items = await entities.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PageResult<TEntity>
            {
                PageNo = pageIndex,
                PageSize = pageSize,
                Rows = items,
                TotalRows = totalCount,
                TotalPage = totalPages
            };
        }



    }
}
