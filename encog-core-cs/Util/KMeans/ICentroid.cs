//
// Encog(tm) Core v3.1 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2012 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace Encog.Util.KMeans
{
    /// <summary>
    /// A centroid.
    /// </summary>
    /// <typeparam name="TO">The type.</typeparam>
    public interface ICentroid<in TO>
    {        
        /// <summary>
        /// Add an element to the centroid.
        /// </summary>
        /// <param name="e">The element to add.</param>
        void Add(TO e);

        /// <summary>
        /// Remove an element from the centroid. 
        /// </summary>
        /// <param name="o">The element to remove.</param>
        void Remove(TO o);

        /// <summary>
        /// The distance between this centroid and an element. 
        /// </summary>
        /// <param name="o">The element.</param>
        /// <returns>The distance.</returns>
        double Distance(TO o);
    }
}
