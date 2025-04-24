import doctorImage from '../assets/doctors.png'; // Use the actual image you added

function HomePage() {
  return (
    <section className="bg-[#02174e] text-white min-h-screen pt-32 px-8">
      <div className="max-w-7xl mx-auto flex flex-col md:flex-row items-center gap-12">
        {/* Text Section */}
        <div className="flex-1">
          <h2 className="text-2xl md:text-3xl lg:text-4xl mb-4 font-light">Welcome to HealthCare</h2>
          <h1 className="text-4xl md:text-5xl lg:text-6xl font-bold text-green-400 mb-6">
            We Are Providing Best & Affordable Health Care.
          </h1>
       
        </div>

        {/* Image Section */}
        <div className="flex-1">
          <img src={doctorImage} alt="Doctors" className="w-full h-auto object-cover" />
        </div>
      </div>
    </section>
  );
}

export default HomePage;
