/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Flv录制参数。
        /// </summary>
        [JsonProperty("FlvParam")]
        public RecordParam FlvParam{ get; set; }

        /// <summary>
        /// Hls录制参数。
        /// </summary>
        [JsonProperty("HlsParam")]
        public RecordParam HlsParam{ get; set; }

        /// <summary>
        /// Mp4录制参数。
        /// </summary>
        [JsonProperty("Mp4Param")]
        public RecordParam Mp4Param{ get; set; }

        /// <summary>
        /// Aac录制参数。
        /// </summary>
        [JsonProperty("AacParam")]
        public RecordParam AacParam{ get; set; }

        /// <summary>
        /// 0：普通直播，
        /// 1：慢直播。
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "FlvParam.", this.FlvParam);
            this.SetParamObj(map, prefix + "HlsParam.", this.HlsParam);
            this.SetParamObj(map, prefix + "Mp4Param.", this.Mp4Param);
            this.SetParamObj(map, prefix + "AacParam.", this.AacParam);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
        }
    }
}

