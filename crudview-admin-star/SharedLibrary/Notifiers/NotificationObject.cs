/*  Copyright [2018] [Invincible Technologies]
 *  
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *    
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Core.Notifiers
{
    /// <summary>
    /// NotificationObject extends from EventArgs and used for messages or information routing during events invocations.
    /// </summary>
    public class NotificationObject : EventArgs
    {
        /// <summary>
        /// Source of the event.
        /// </summary>
        public Object Source { get; set; }

        /// <summary>
        /// Constructor initialization.
        /// </summary>
        public NotificationObject()
        {
        }

        /// <summary>
        /// Constructor intitialization with source object.
        /// </summary>
        /// <param name="source"></param>
        public NotificationObject(Object source)
        {
            this.Source = source;
        }
    }
}
