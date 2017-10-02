﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;
using DAL.DataAccess;
using DALocean.DataAccess;

namespace PrompRepositories.Services.DBconnection
{
    /// <summary>
    /// ContextConnection
    /// </summary>
    /// CTE Assessments Refactoring Reposioties and New approach 7/9/2015,
    /// dcuevas
    public class ContextConnection
    {
        static DbContext context;
        static bool oceancontext = false;
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        /// CTE Assessments Refactoring Reposioties and New approach 7/9/2015,
        /// dcuevas
        /// 


       public static bool ContextOcean
        {
            get {
                return oceancontext;
            }
            set
            {
                oceancontext = value;
            }
        }


        public static DbContext SetContextConnection()
        {
            if (ContextOcean)
            {
                return new NewOceanicarefEntities();
            }

            return  new PrompEntitiesDev();
        }
        public static DbContext Context
        {
            //// single entity // teacher and school good 02/27 !!!!!
            // working fine 03/04 need to refresh the entity framework
            get
            {
                if (context == null || ContextOcean )
                {
                    try
                    {
                        context = SetContextConnection();
                        return context;
                    }
                    catch (Exception error)
                    {
                        // elmah ErrorSignal.FromCurrentContext().Raise(error);
                        return null;
                    }

                }
                return context;
            }
            set
            {
                context = value;
            }

        }


        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        /// CTE Assessments Refactoring Sep - Oct 2014, David Cuevas
        public static void Refresh()
        {
            var refreshdbcontext = ((IObjectContextAdapter)Context).ObjectContext;
            var refreshableObjects = (from entry in refreshdbcontext.ObjectStateManager.GetObjectStateEntries(
                                            EntityState.Added
                                            | EntityState.Deleted
                                            | EntityState.Modified
                                            | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity).Where(objt => objt != null);

            if (refreshableObjects != null)
            {
                if (refreshableObjects.Count() > 1)
                {
                    refreshdbcontext.Refresh(RefreshMode.StoreWins, refreshableObjects);
                }
            }
        }
    }
}
