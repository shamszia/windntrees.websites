﻿/*  Copyright [2018] [Invincible Technologies]
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
    /// LocaleStringLength extends StringLengthAttribute class and let users to decorate fields for validating length limited inputs. Override GetLocaleMessage to get a customized validation message.
    /// </summary>
    public partial class LocaleStringLength : StringLengthAttribute
    {
        /// <summary>
        /// Constructor initialization with comparing length limit value.
        /// </summary>
        /// <param name="maximumLength"></param>
        public LocaleStringLength(int maximumLength)
            : base(maximumLength)
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
                if (MinimumLength > 0)
                {
                    return string.Format("The field {0} must be a string with a minimum length of {1} and a maximum length of {2}.", name, MinimumLength, MaximumLength);
                }

                return string.Format("The field {0} must be a string with maximum length of {1}", name, MaximumLength);
            }

            return GetLocaleMessage(name);
        }
    }
}