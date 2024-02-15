import classes from "./DoctorCard.module.css";

export default function DoctorCard(props) {
  return (
    <div className={classes.show}>
      {props.data?.items?.map((item, index) => (
        <div key={index} className={classes["flip-card"]}>
          <div className={classes.personalInfo}>
            <h1>{item.name}</h1>
            <h2>{item.second_name}</h2>
            <h3>{item.last_name}</h3>
          </div>

          {item.addresses?.map((data, index) => (
            <div key={index} className={classes.openInfo}>
              <div className={classes.addressInfo}>
                <p>Ulica: {data.street}</p>
                <p>Numer domu: {data.building_number}</p>
                <p>Numer lokalu: {data.apartament_number}</p>
                <p>Kod pocztowy: {data.postal_code}</p>
                <p>Miasto: {data.city}</p>
              </div>

              <div className={classes.daysInfo}>
                <p>Poniedziałek: {data.monday}</p>
                <p>Wtorek: {data.tuesday}</p>
                <p>Środa: {data.wednesday}</p>
                <p>Czwartek: {data.thursday}</p>
                <p>Piątek: {data.fridady}</p>
                <p>Sobota: {data.saturday}</p>
                <p>Niedziela: {data.sunday}</p>
              </div>
            </div>
          ))}
        </div>
      ))}
    </div>
  );
}
