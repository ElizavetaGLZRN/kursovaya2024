using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Курсовая;

namespace тестирование
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestButton1()
        {
            Form2 form = new Form2();
            form.Button1_Click(null, null);

            // Проверяем, что progressbar3.value установлено в 100
            Assert.AreEqual(100, form.ProgressBar3.Value);

            
        }

        [TestMethod]
        public void TestButton2()
        {
            Form2 form = new Form2();
            form.Button2_Click(null, null);

            // Проверяем, что при значении progressbar2.value < progressbar2.maximum - 10,
            // progressbar2.value увеличивается на 10
            if (form.ProgressBar2.Value < form.ProgressBar2.Value - 10)
            {
                Assert.AreEqual(form.ProgressBar2.Value + 10, form.ProgressBar2.Value);
            }

            // Проверяем, что при значении progressbar2.value > progressbar2.maximum - 10,
            // кнопка button2 становится неактивной
            if (form.ProgressBar2.Value > form.ProgressBar2.Maximum - 10)
            {
                Assert.IsFalse(form.Button2.Enabled);
            }
        }

        [TestMethod]
        public void TestButton3()
        {
            Form2 form = new Form2();
            form.Button3_Click(null, null);

            

            // Проверяем, что sleep установлено в 1
            Assert.AreEqual(1, form.sleep);

            // Проверяем, что кнопки button1 и button2 становятся неактивными
            Assert.IsFalse(form.Button1.Enabled);
            Assert.IsFalse(form.Button2.Enabled);
        }

        [TestMethod]
        public void TestButton4()
        {
            Form2 form = new Form2();
            form.Button4_Click(null, null);

            

            // Проверяем, что sleep установлено в 0
            Assert.AreEqual(0, form.sleep);

            // Проверяем, что кнопки button1 и button2 становятся активными
            Assert.IsTrue(form.Button1.Enabled);
            Assert.IsTrue(form.Button2.Enabled);
        }
    }
}