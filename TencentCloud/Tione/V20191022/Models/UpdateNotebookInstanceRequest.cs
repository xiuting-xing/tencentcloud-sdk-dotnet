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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateNotebookInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// 角色的资源描述
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// Root访问权限
        /// </summary>
        [JsonProperty("RootAccess")]
        public string RootAccess{ get; set; }

        /// <summary>
        /// 数据卷大小(GB)
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// 算力资源类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// notebook生命周期脚本名称
        /// </summary>
        [JsonProperty("LifecycleScriptsName")]
        public string LifecycleScriptsName{ get; set; }

        /// <summary>
        /// 是否解绑生命周期脚本，默认 false。
        /// 如果本来就没有绑定脚本，则忽略此参数；
        /// 如果本来有绑定脚本，此参数为 true 则解绑；
        /// 如果本来有绑定脚本，此参数为 false，则需要额外填入 LifecycleScriptsName
        /// </summary>
        [JsonProperty("DisassociateLifecycleScript")]
        public bool? DisassociateLifecycleScript{ get; set; }

        /// <summary>
        /// 默认存储库名称
        /// 可以是已创建的存储库名称或者已https://开头的公共git库
        /// </summary>
        [JsonProperty("DefaultCodeRepository")]
        public string DefaultCodeRepository{ get; set; }

        /// <summary>
        /// 其他存储库列表
        /// 每个元素可以是已创建的存储库名称或者已https://开头的公共git库
        /// </summary>
        [JsonProperty("AdditionalCodeRepositories")]
        public string[] AdditionalCodeRepositories{ get; set; }

        /// <summary>
        /// 是否取消关联默认存储库，默认false
        /// 该值为true时，DefaultCodeRepository将被忽略
        /// </summary>
        [JsonProperty("DisassociateDefaultCodeRepository")]
        public bool? DisassociateDefaultCodeRepository{ get; set; }

        /// <summary>
        /// 是否取消关联其他存储库，默认false
        /// 该值为true时，AdditionalCodeRepositories将被忽略
        /// </summary>
        [JsonProperty("DisassociateAdditionalCodeRepositories")]
        public bool? DisassociateAdditionalCodeRepositories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookInstanceName", this.NotebookInstanceName);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "RootAccess", this.RootAccess);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "LifecycleScriptsName", this.LifecycleScriptsName);
            this.SetParamSimple(map, prefix + "DisassociateLifecycleScript", this.DisassociateLifecycleScript);
            this.SetParamSimple(map, prefix + "DefaultCodeRepository", this.DefaultCodeRepository);
            this.SetParamArraySimple(map, prefix + "AdditionalCodeRepositories.", this.AdditionalCodeRepositories);
            this.SetParamSimple(map, prefix + "DisassociateDefaultCodeRepository", this.DisassociateDefaultCodeRepository);
            this.SetParamSimple(map, prefix + "DisassociateAdditionalCodeRepositories", this.DisassociateAdditionalCodeRepositories);
        }
    }
}

