// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Vigo.Engine.Abstraction;

namespace Vigo.Engine.Query.Extension;

public static class WithAllExtension
{
    public static IQuery WithAll(this IQuery query, params string[] fields)
    {
        foreach (var field in fields)
        {
            query.With(field);
        }

        return query;
    }
}