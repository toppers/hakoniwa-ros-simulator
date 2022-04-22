//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Ev3
{
    [Serializable]
    public class Ev3PduSensorMsg : Message
    {
        public const string k_RosMessageName = "ev3_msgs/Ev3PduSensor";
        public override string RosMessageName => k_RosMessageName;

        public Ev3PduSensorHeaderMsg head;
        public byte[] buttons;
        public Ev3PduColorSensorMsg[] color_sensors;
        public Ev3PduTouchSensorMsg[] touch_sensors;
        public uint[] motor_angle;
        public int gyro_degree;
        public int gyro_degree_rate;
        public uint sensor_ultrasonic;
        public double gps_lat;
        public double gps_lon;

        public Ev3PduSensorMsg()
        {
            this.head = new Ev3PduSensorHeaderMsg();
            this.buttons = new byte[1];
            this.color_sensors = new Ev3PduColorSensorMsg[2];
            this.touch_sensors = new Ev3PduTouchSensorMsg[2];
            this.motor_angle = new uint[3];
            this.gyro_degree = 0;
            this.gyro_degree_rate = 0;
            this.sensor_ultrasonic = 0;
            this.gps_lat = 0.0;
            this.gps_lon = 0.0;
        }

        public Ev3PduSensorMsg(Ev3PduSensorHeaderMsg head, byte[] buttons, Ev3PduColorSensorMsg[] color_sensors, Ev3PduTouchSensorMsg[] touch_sensors, uint[] motor_angle, int gyro_degree, int gyro_degree_rate, uint sensor_ultrasonic, double gps_lat, double gps_lon)
        {
            this.head = head;
            this.buttons = buttons;
            this.color_sensors = color_sensors;
            this.touch_sensors = touch_sensors;
            this.motor_angle = motor_angle;
            this.gyro_degree = gyro_degree;
            this.gyro_degree_rate = gyro_degree_rate;
            this.sensor_ultrasonic = sensor_ultrasonic;
            this.gps_lat = gps_lat;
            this.gps_lon = gps_lon;
        }

        public static Ev3PduSensorMsg Deserialize(MessageDeserializer deserializer) => new Ev3PduSensorMsg(deserializer);

        private Ev3PduSensorMsg(MessageDeserializer deserializer)
        {
            this.head = Ev3PduSensorHeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.buttons, sizeof(byte), 1);
            deserializer.Read(out this.color_sensors, Ev3PduColorSensorMsg.Deserialize, 2);
            deserializer.Read(out this.touch_sensors, Ev3PduTouchSensorMsg.Deserialize, 2);
            deserializer.Read(out this.motor_angle, sizeof(uint), 3);
            deserializer.Read(out this.gyro_degree);
            deserializer.Read(out this.gyro_degree_rate);
            deserializer.Read(out this.sensor_ultrasonic);
            deserializer.Read(out this.gps_lat);
            deserializer.Read(out this.gps_lon);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.head);
            serializer.Write(this.buttons);
            serializer.Write(this.color_sensors);
            serializer.Write(this.touch_sensors);
            serializer.Write(this.motor_angle);
            serializer.Write(this.gyro_degree);
            serializer.Write(this.gyro_degree_rate);
            serializer.Write(this.sensor_ultrasonic);
            serializer.Write(this.gps_lat);
            serializer.Write(this.gps_lon);
        }

        public override string ToString()
        {
            return "Ev3PduSensorMsg: " +
            "\nhead: " + head.ToString() +
            "\nbuttons: " + System.String.Join(", ", buttons.ToList()) +
            "\ncolor_sensors: " + System.String.Join(", ", color_sensors.ToList()) +
            "\ntouch_sensors: " + System.String.Join(", ", touch_sensors.ToList()) +
            "\nmotor_angle: " + System.String.Join(", ", motor_angle.ToList()) +
            "\ngyro_degree: " + gyro_degree.ToString() +
            "\ngyro_degree_rate: " + gyro_degree_rate.ToString() +
            "\nsensor_ultrasonic: " + sensor_ultrasonic.ToString() +
            "\ngps_lat: " + gps_lat.ToString() +
            "\ngps_lon: " + gps_lon.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
