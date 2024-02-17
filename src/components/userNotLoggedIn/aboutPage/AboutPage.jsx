import './about.css';

function AboutContent() {
  return (
    <div style={{
      display: 'flex',
      justifyContent: 'center',
    }}> 
      <p className='mainContainer'>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla turpis orci, tempor non elementum molestie, accumsan vel nulla. Integer gravida odio velit. In sit amet turpis dolor. Nulla sit amet turpis lectus. Nunc vel sollicitudin felis. Integer faucibus blandit nisl vel vehicula. Aliquam ultrices nec ligula in mollis. Praesent viverra mollis pharetra. Etiam semper nunc non enim placerat commodo. Proin elementum dapibus vestibulum. Nunc nunc velit, facilisis in eros ac, eleifend molestie neque. Nam in metus non nisi viverra rutrum et in quam. Nam eu risus et nunc dapibus efficitur vel ut risus. Integer non tristique erat.

  Etiam id feugiat felis, imperdiet maximus magna. Cras imperdiet feugiat erat. Integer hendrerit risus a elit ultrices cursus. Donec eu tortor lacus. Nullam non lacus posuere ligula venenatis faucibus. Donec sed quam imperdiet turpis dictum auctor. Ut rutrum, eros ut pulvinar bibendum, mi dolor commodo odio, sodales fermentum urna dolor sed ipsum. Etiam mattis a quam a fermentum. Fusce sollicitudin venenatis varius. Praesent dui justo, accumsan non pretium suscipit, semper eu libero. Proin nibh lorem, pharetra et massa sed, posuere venenatis ipsum. Donec vitae sagittis nisi, id malesuada orci. Quisque et mauris dictum, iaculis magna sed, cursus neque. Pellentesque non quam velit. In euismod id tellus in tempus.

  Nullam ornare sit amet mi sed feugiat. Nullam egestas consectetur ex a pretium. Nullam a viverra tortor. Nulla facilisi. Cras iaculis eros turpis, vel tincidunt est mattis et. Nullam laoreet risus sit amet ipsum tristique, a molestie ipsum sollicitudin. Vivamus sit amet ipsum et tellus efficitur vulputate. Donec accumsan pharetra turpis, eu commodo quam pharetra eget. Proin faucibus pretium erat, nec accumsan turpis sollicitudin eu. Quisque aliquet convallis magna eget rutrum. Aliquam at lectus fermentum, tincidunt quam vitae, ultrices mauris. Ut porta at arcu sed laoreet. Curabitur sagittis velit nec purus pretium, sed maximus elit dignissim. Integer condimentum consequat turpis eu varius.
      </p>
    </div>
  );
}


function AboutPage() {

  return (    
  <div>
    <AboutContent />
  </div>
  );
}

export default AboutPage;
