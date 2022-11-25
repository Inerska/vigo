// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace Vigo.Engine.Abstraction;

public abstract class Baker<T>
    where T : class
{
    public abstract void Bake(T authoring);
}