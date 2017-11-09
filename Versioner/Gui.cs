/*
 * ******************************************************************************
 *    Copyright 2016-2017 Spectra Logic Corporation. All Rights Reserved.
 *    Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *    this file except in compliance with the License. A copy of the License is located at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *  
 *    or in the "license" file accompanying this file.
 *    This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *    CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *    specific language governing permissions and limitations under the License.
 * ******************************************************************************
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Versioner
{
    public partial class Gui : Form
    {
        int oldVersionMajor;
        int oldVersionMinor;
        int oldVersionRev;
        int oldVersionX;

        int newVersionMajor;
        int newVersionMinor;
        int newVersionRev;

        public Gui()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            InitOldVersion();
            InitNewVersion();
        }

        private void InitOldVersion()
        {
            var oldVersion = GetOldVersion();
            var str = oldVersion.Split('.');
            numericUpDownOldVersionMajor.Value = oldVersionMajor = int.Parse(str[0]);
            numericUpDownOldVersionMinor.Value = oldVersionMinor = int.Parse(str[1]);
            numericUpDownOldVersionRev.Value = oldVersionRev = int.Parse(str[2]);
            oldVersionX = int.Parse(str[3]);
        }

        private void InitNewVersion()
        {
            numericUpDownNewVersionMajor.Value = newVersionMajor = (int)numericUpDownOldVersionMajor.Value;
            numericUpDownNewVersionMinor.Value = newVersionMinor = (int)numericUpDownOldVersionMinor.Value;
            numericUpDownNewVersionRev.Value = newVersionRev = (int)numericUpDownOldVersionRev.Value + 1;
        }

        private string GetOldVersion()
        {
            try
            {
                var str = File.ReadAllLines("Version.cs");
                var x = str[4].IndexOf('"') + 1;
                var y = str[4].LastIndexOf('"');
                var z = y - x;

                return str[4].Substring(x, z);
            } catch(Exception ex)
            {
                MessageBox.Show(Strings.FailedToGetOldVersion, Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.0.0.0";
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var versionStr = File.ReadAllText("Version.cs");
                File.WriteAllText("Version.cs", versionStr.Replace(
                    $"{oldVersionMajor}.{oldVersionMinor}.{oldVersionRev}.{oldVersionX}",
                    $"{newVersionMajor}.{newVersionMinor}.{newVersionRev}.0"));

                var setupProjectStr = File.ReadAllText("SetupProject\\SetupProject.wixproj");
                File.WriteAllText("SetupProject\\SetupProject.wixproj", setupProjectStr.Replace(
                    $"{oldVersionMajor}.{oldVersionMinor}.{oldVersionRev}",
                    $"{newVersionMajor}.{newVersionMinor}.{newVersionRev}"));

                MessageBox.Show(Strings.Success, Strings.Update, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Init();
            } catch(Exception ex)
            {
                MessageBox.Show(Strings.FailedToUpdate, Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumericUpDownNewVersionMajor_ValueChanged(object sender, EventArgs e)
        {
            newVersionMajor = (int)numericUpDownNewVersionMajor.Value;
        }

        private void NumericUpDownNewVersionMinor_ValueChanged(object sender, EventArgs e)
        {
            newVersionMinor = (int)numericUpDownNewVersionMinor.Value;
        }

        private void NumericUpDownNewVersionRev_ValueChanged(object sender, EventArgs e)
        {
            newVersionRev = (int)numericUpDownNewVersionRev.Value;
        }
    }
}
