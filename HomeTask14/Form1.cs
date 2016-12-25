using ArrayBased;
using DynamicArrayBased;
using LinkedListBased;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask14
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void runTestAddArrayBasedButton_Click(object sender, EventArgs e)
        {
            int size = 0;
            if (!Int32.TryParse(numberOfElementsToAddTextBox.Text, out size) || size == 0)
            {
                MessageBox.Show(String.Format("Please, check the value you entered in 'Number Of Elements To Add:' field"));
            }
            else
            {
                Stopwatch watchArrayStackAdd = new Stopwatch();
                Stopwatch watchDynamicArrayStackAdd = new Stopwatch();
                Stopwatch watchLinkedListStackAdd = new Stopwatch();
                Stopwatch watchEmbeddedStackAdd = new Stopwatch();
                                
                Stopwatch watchArrayStackRemove = new Stopwatch();
                Stopwatch watchDynamicArrayStackRemove = new Stopwatch();
                Stopwatch watchLinkedListStackRemove = new Stopwatch();
                Stopwatch watchEmbeddedStackRemove = new Stopwatch();
                
                //Array based
                watchArrayStackAdd.Start();
                var newArrayBasedStack = new MyStack<int>(size);
                for (int i = 0; i < size; i++)
                {
                    newArrayBasedStack.Push(123);
                }
                watchArrayStackAdd.Stop();
                resultValueAddArrayBasedStackLabel.Text = String.Format("{0} ms", watchArrayStackAdd.ElapsedMilliseconds);

                watchArrayStackRemove.Start();
                int tempValue1 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue1 = newArrayBasedStack.Pop();
                }
                watchArrayStackRemove.Stop();
                resultValueRemoveArrayBasedStackLabel.Text = String.Format("{0} ms", watchArrayStackRemove.ElapsedMilliseconds);
                

                //DynamicArray based
                watchDynamicArrayStackAdd.Start();
                var newDynamicArrayBasedStack = new DynamicStack<int>(1, size);
                for (int i = 0; i < size; i++)
                {
                    newDynamicArrayBasedStack.Push(123);
                }
                watchDynamicArrayStackAdd.Stop();
                resultValueAddDynamicArrayBasedStackLabel.Text = String.Format("{0} ms", watchDynamicArrayStackAdd.ElapsedMilliseconds);

                watchDynamicArrayStackRemove.Start();
                int tempValue2 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue2 = newDynamicArrayBasedStack.Pop();
                }
                watchDynamicArrayStackRemove.Stop();
                resultValueRemoveDynamicArrayBasedStackLabel.Text = String.Format("{0} ms", watchDynamicArrayStackRemove.ElapsedMilliseconds);
                

                //LinkedList based
                watchLinkedListStackAdd.Start();
                var newLinkedListBasedStack = new MyLinkeListStack<int>(size);
                for (int i = 0; i < size; i++)
                {
                    newLinkedListBasedStack.Push(123);
                }
                watchLinkedListStackAdd.Stop();
                resultValueAddLinkedListBasedStackLabel.Text = String.Format("{0} ms", watchLinkedListStackAdd.ElapsedMilliseconds);
                
                watchLinkedListStackRemove.Start();
                int tempValue3 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue3 = newLinkedListBasedStack.Pop();
                }
                watchLinkedListStackRemove.Stop();
                resultValueRemoveLinkedListBasedStackLabel.Text = String.Format("{0} ms", watchLinkedListStackRemove.ElapsedMilliseconds);
                
                
                //Embedded based
                watchEmbeddedStackAdd.Start();
                List<int> embeddedList = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    embeddedList.Add(123);
                }
                watchEmbeddedStackAdd.Stop();
                resultValueAddEmbeddedStackBasedLabel.Text = String.Format("{0} ms", watchEmbeddedStackAdd.ElapsedMilliseconds);
                
                watchEmbeddedStackRemove.Start();                
                for (int i = 0; i < size; i++)
                {
                    embeddedList.Remove(123);
                }
                watchEmbeddedStackRemove.Stop();
                resultValueRemoveEmbeddedStackBasedLabel.Text = String.Format("{0} ms", watchEmbeddedStackRemove.ElapsedMilliseconds);
                

            }




        }

        private void numberOfElemtsToAddLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainViewGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void numberOfElementsToAddTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultValueAddArrayBasedLabel_Click(object sender, EventArgs e)
        {

        }

        private void runTestAddArrayBasedQueueButton_Click(object sender, EventArgs e)
        {

            int size = 0;
            if (!Int32.TryParse(numberOfElementsToAddTextBox.Text, out size) || size == 0)
            {
                MessageBox.Show(String.Format("Please, check the value you entered in 'Number Of Elements To Add:' field"));
            }
            else
            {
                Stopwatch watchArrayQueueAdd = new Stopwatch();
                Stopwatch watchDynamicArrayQueueAdd = new Stopwatch();
                Stopwatch watchLinkedListQueueAdd = new Stopwatch();
                Stopwatch watchEmbeddedQueueAdd = new Stopwatch();
                                
                Stopwatch watchArrayQueueRemove = new Stopwatch();
                Stopwatch watchDynamicArrayQueueRemove = new Stopwatch();
                Stopwatch watchLinkedListQueueRemove = new Stopwatch();
                Stopwatch watchEmbeddedQueueRemove = new Stopwatch();
                

                //Array based
                watchArrayQueueAdd.Start();
                var newArrayBasedQueue = new MyQueue<int>(size);
                for (int i = 0; i < size; i++)
                {
                    newArrayBasedQueue.Enqueue(123);
                }
                watchArrayQueueAdd.Stop();
                resultValueAddArrayBasedQueueLabel.Text = String.Format("{0} ms", watchArrayQueueAdd.ElapsedMilliseconds);

                watchArrayQueueRemove.Start();
                int tempValue5 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue5 = newArrayBasedQueue.Dequeue();
                }
                watchArrayQueueRemove.Stop();
                resultValueRemoveArrayBasedQueueLabel.Text = String.Format("{0} ms", watchArrayQueueRemove.ElapsedMilliseconds);
                


                //DynamicArray based
                watchDynamicArrayQueueAdd.Start();
                var newDynamicArrayBasedQueue = new DynamicQueue<int>(1, size);
                for (int i = 0; i < size; i++)
                {
                    newDynamicArrayBasedQueue.Enqueue(123);
                }
                watchDynamicArrayQueueAdd.Stop();
                resultValueAddDynamicArrayBasedQueueLabel.Text = String.Format("{0} ms", watchDynamicArrayQueueAdd.ElapsedMilliseconds);

                watchDynamicArrayQueueRemove.Start();
                int tempValue6 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue6 = newDynamicArrayBasedQueue.Dequeue();
                }
                watchDynamicArrayQueueRemove.Stop();
                resultValueRemoveDynamicArrayBasedQueueLabel.Text = String.Format("{0} ms", watchDynamicArrayQueueRemove.ElapsedMilliseconds);



                //LinkedList based
                watchLinkedListQueueAdd.Start();
                var newLinkedListBasedQueue = new MyLinkedListQueue<int>(size);
                for (int i = 0; i < size; i++)
                {
                    newLinkedListBasedQueue.Enqueue(123);
                }
                watchLinkedListQueueAdd.Stop();
                resultValueAddLinkedListBasedQueueLabel.Text = String.Format("{0} ms", watchLinkedListQueueAdd.ElapsedMilliseconds);

                watchLinkedListQueueRemove.Start();
                int tempValue7 = 0;
                for (int i = 0; i < size; i++)
                {
                    tempValue7 = newLinkedListBasedQueue.Dequeue();
                }
                watchLinkedListQueueRemove.Stop();
                resultValueRemoveLinkedListBasedQueueLabel.Text = String.Format("{0} ms", watchLinkedListQueueRemove.ElapsedMilliseconds);



                //Embedded based
                watchEmbeddedQueueAdd.Start();
                Queue<int> embeddedQueue = new Queue<int>();
                for (int i = 0; i < size; i++)
                {
                    embeddedQueue.Enqueue(123);
                }
                watchEmbeddedQueueAdd.Stop();
                resultValueAddEmbeddedQueueBasedLabel.Text = String.Format("{0} ms", watchEmbeddedQueueAdd.ElapsedMilliseconds);

                watchEmbeddedQueueRemove.Start();
                
                for (int i = 0; i < size; i++)
                {
                    embeddedQueue.Dequeue();
                }
                watchEmbeddedQueueRemove.Stop();
                resultValueRemoveEmbeddedQueueBasedLabel.Text = String.Format("{0} ms", watchEmbeddedQueueRemove.ElapsedMilliseconds);

            }
        }

    }
}
