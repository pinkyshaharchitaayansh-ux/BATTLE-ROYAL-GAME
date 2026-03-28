{
    public float damage = 10f;
    public float range = 100f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Left mouse click
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log("Hit " + hit.transform.name);
        }
    }
}


