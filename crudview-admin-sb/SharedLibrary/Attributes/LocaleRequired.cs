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

using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Core.Attributes
{
    /// <summary>
    /// LocaleRequired extends RequiredAttribute class and let users to decorate fields for validating required inputs. Override GetLocaleMessage to get a customized validation message.
    /// </summary>
    public partial class LocaleRequired : RequiredAttribute
    {
        /// <summary>
        /// Constructor initialization.
        /// </summary>
        public LocaleRequired()
        {   

        }

        /// <summary>
        /// Override to get locale message.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual string GetLocaleMessage(string name)
        {
            return null;
        }

        /// <summary>
        /// Gets formatted locale message, override to format error message.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name)
        {
            if (GetLocaleMessage(name) == null)
            {
                return "This field is required.";
            }
            return GetLocaleMessage(name);
        }
    }
}