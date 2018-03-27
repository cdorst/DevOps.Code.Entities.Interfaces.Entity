// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Code.Entities.Interfaces.Entity
{
    /// <summary>Common interface for code-generated entity types</summary>
    public interface IEntity<TKey>
    {
        /// <summary>Returns the unique identifier of the entity type</summary>
        int GetEntityType();

        /// <summary>Returns the unique identifier of this entity instance</summary>
        TKey GetKey();
    }
}
