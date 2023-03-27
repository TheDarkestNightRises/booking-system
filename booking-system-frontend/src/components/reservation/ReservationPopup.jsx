import ReservationForm from "./ReservationForm";
import "./ReservationPopup.css";

function RoomTablePopup({ room, onClose }) {
  return (
    <div className="popup">
      <div className="popup-inner">
        <h2>{room.name} Reservation Form</h2>
        <ReservationForm room={room} />
        <button className="close-btn" onClick={onClose}>
          X
        </button>
      </div>
    </div>
  );
}

export default RoomTablePopup;
