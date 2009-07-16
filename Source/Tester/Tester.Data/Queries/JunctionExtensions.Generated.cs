﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Data.Linq;

namespace Tester.Data
{
    /// <summary>
    /// The query extension class for Junction.
    /// </summary>
    public static partial class JunctionExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tester.Data.Junction GetByKey(this IQueryable<Tester.Data.Junction> queryable, int leftId, int rightId)
        {
            var entity = queryable as System.Data.Linq.Table<Tester.Data.Junction>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tester.Data.TesterDataContext)entity.Context, leftId, rightId);
            
            return queryable.FirstOrDefault(j => j.LeftId == leftId 
					&& j.RightId == rightId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tester.Data.Junction> table, int leftId, int rightId)
        {
            return table.Delete(j => j.LeftId == leftId 
					&& j.RightId == rightId);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tester.Data.TesterDataContext, int, int, Tester.Data.Junction> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tester.Data.TesterDataContext db, int leftId, int rightId) => 
                        db.Junction.FirstOrDefault(j => j.LeftId == leftId 
							&& j.RightId == rightId));

        }
        #endregion
    }
}

