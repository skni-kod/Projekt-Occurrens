import classes from "./MainPage.module.css";

function MainPage() {
  return (
    <>
      <div className={classes.background}>
        <div className={classes.header}>
        <div className={classes.description}>
        <p className={classes.information}>Zarejestruj Się Jeszcze Dzisiaj<br/>I Odnajdź Swojego <span className={classes.blue}>Lekarza</span></p>
        <button className={classes.button}>Dowiedz się więcej</button>
        </div>
        <img className={classes.youngdoctor} src="https://s3-alpha-sig.figma.com/img/a653/2413/6a6420cea274a61621dbd5ee3bd89708?Expires=1708905600&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=bNI7MlYXSW6iEpQQwdnHurVT88QCgMEWtdn5txUHpINLE~Q0Xt8TroePKjTQ7OTF-v7KGoK9oSjyvZ3b3KF5wrVTeosmQPEmWHZESzItbKhDZP-3koPsa9XcByzm75jJxkYpHrYUnXPxqvOeLSQ-iZ2xAQYUFI0Z-O1Oap5ehU0aJOh8xaYgtnPS8icRtImkcF9PyBXoS02fFaH9BaT8wXnTZOVA0pyZPurQdjSvllyGbJNQEKgTS~3OQwE7Wa-VO-54fWVGYFBWJuRVAhNLIBprwol5Tg54Ix1RYMwVZVE2QRy7MBtQPlGv6bk8aPNWM8btLENRUR8R3uSL1Q9w4Q__" />
        </div>
      </div>
    </>
    );
}

export default MainPage;