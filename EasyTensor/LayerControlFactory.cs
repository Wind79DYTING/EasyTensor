using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EasyTensor.Controls;
using Tensorflow.Keras;
using Tensorflow.Keras.Engine;

namespace EasyTensor
{
    public interface ILayerControlFactory
    {
        LayerControlBase CreateLayerControl(string type, Color backColor, string text);
    }

    public class LayerControlFactory : ILayerControlFactory
    {
        private const string ConvLayer = "Conv";
        private const string MaxPoolingLayer = "MaxPooling";

        public LayerControlBase CreateLayerControl(string type, Color backColor, string text) =>
            type switch
            {
                ConvLayer => new ConvLayerControl(backColor, text),
                MaxPoolingLayer => new MaxPoolingLayerControl(backColor, text),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
    }
}
