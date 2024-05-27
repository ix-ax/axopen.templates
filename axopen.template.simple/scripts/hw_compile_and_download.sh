if [ "$#" -ne 2 ]; then
    echo "Usage: $0 <PLC_NAME> <PLC_IP_ADDRESS>"
    exit 1
fi

PLC_NAME=$1
if [ -z $PLC_NAME ]; then
    echo "The PLC_NAME could not be an empty string."
    exit 1
fi

PLC_IP_ADDRESS=$2
validate_script=$( dirname ${BASH_SOURCE[0]})"\\validate_ip.sh"
if ! $validate_script "$PLC_IP_ADDRESS"; then
    echo "The PLC_IP_ADDRESS '$PLC_IP_ADDRESS' is not a valid IP address."
    exit 1
fi

if ! [[ -d "./hwc" ]]; then
  echo "Directory ".\hwc" does not exist!!!"
  exit 1
fi
hwcfile=".\hwc\\${PLC_NAME}.hwl.json"
if ! [[ -e "$hwcfile" ]]; then
  echo "Hardware configuration file $hwcfile does not exist!!!"
  exit 1
fi 

certfile="./certs/$PLC_NAME/$PLC_NAME.cer"
if ! [[ -e "$certfile" ]]; then
  echo "Certification file $certfile does not exist!!!"
  exit 1
fi        

apax hwc compile -i ".\hwc" -o bin/hwc/
hwid=$( dirname ${BASH_SOURCE[0]})"\\copy_hardware_ids.sh"
$hwid
apax hwld -i bin/hwc/$PLC_NAME -t $PLC_IP_ADDRESS -C $certfile --nonInteractive --accept-security-disclaimer -l Information
